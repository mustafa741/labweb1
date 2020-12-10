class News {
    _title = '';
    _author = '';
    _content = '';

    constructor(title, author, content) {
        this._title = title;
        this._author = author;
        this._content = content;
    }
}


// todo: в 3 лабе здесь нужно делать запросы к серверу (ajax)
class NewsRepository {

    // todo: делать запрос к серверу
    getAll() {
        return NewsRepository._getNewsArray()
    }

    // todo: делать запрос к серверу
    save(news) {
        let newsDb = NewsRepository._getNewsArray()
        if (newsDb.length <= 50) {
            newsDb.push(news)
            NewsRepository._setNewsArray(newsDb)
        } else {
            alert("Закончилось место в хранилище! Удалите старые новости")
        }
    }

    // todo: в 3 лабе у News будет еще поле id, поэтому нужно будет переписать метод на удаление по id (т.е сделать запрос на удаление по id)
    remove(title, author) {
        let filtered = NewsRepository._getNewsArray()
            .filter(news => {
                return !(news._title === title && news._author === author)
            })
        NewsRepository._setNewsArray(filtered)
    }

    // данный метод будет неактуален в 3 лабе
    static _getNewsArray() {
        let newsDb = localStorage.getItem("newsDb")
        if (newsDb === "null" || newsDb == null) {
            return []
        }
        return JSON.parse(newsDb)
    }

    // данный метод будет неактуален в 3 лабе
    static _setNewsArray(newsDb) {
        localStorage.setItem("newsDb", JSON.stringify(newsDb))
    }
}


class ShowNewsOperation {

    _newsRepository

    constructor(newsRepository) {
        this._newsRepository = newsRepository
    }

    execute() {
        let table = document.getElementById("news-table");

        if (table == null) {
            throw new Error("not found 'news-table'")
        }

        this._newsRepository.getAll()
            .some(news => {
                let tr = document.createElement("tr")

                let titleTd = document.createElement("td")
                let authorTd = document.createElement("td")
                let contentTd = document.createElement("td")

                titleTd.innerText = news._title
                authorTd.innerText = news._author
                contentTd.innerText = news._content

                tr.append(titleTd, authorTd, contentTd)
                table.append(tr)
            })
    }
}


class ShowNewsRemoveOperation {

    _newsRepository

    constructor(newsRepository) {
        this._newsRepository = newsRepository
    }

    execute() {
        let table = document.getElementById("news-remove-table");

        if (table == null) {
            throw new Error("not found 'news-remove-table'")
        }

        this._newsRepository.getAll()
            .some(news => {
                let tr = document.createElement("tr")

                let titleTd = document.createElement("td")
                let authorTd = document.createElement("td")
                let removeButton = document.createElement("td")

                titleTd.innerText = news._title
                authorTd.innerText = news._author
                removeButton.innerText = 'X'

                removeButton.addEventListener('click', _ => {
                    let accept = confirm(`Вы действительно хотите удалить новость ${news._title} автора ${news._author}?`)
                    if (accept) {
                        this._newsRepository.remove(news._title, news._author)
                        tr.remove()
                    }
                })

                tr.append(titleTd, authorTd, removeButton)
                table.append(tr)
            })
    }
}


class BindNewsFormOperation {

    _newsRepository

    constructor(newsRepository) {
        this._newsRepository = newsRepository
    }

    execute() {
        let titleInput = document.getElementById('titleInput')
        let authorInput = document.getElementById('authorInput')
        let contentInput = document.getElementById('contentInput')

        document.getElementById('news-form')
            .addEventListener('submit', _ => {
                this._newsRepository.save(new News(titleInput.value, authorInput.value, contentInput.value))

                titleInput.value = ""
                authorInput.value = ""
                contentInput.value = ""
                alert('news added')
            })
    }
}


// очень старый анти-паттерн (божественный объект), но для данной лабораторной работы его более чем достаточно
class Context {

    static _instance = null

    _newsRepository
    _showNewsOperation
    _bindNewsFormOperation
    _showNewsRemoveOperation

    static newsRepository() {
        return Context.getInstance()._newsRepository
    }

    static showNewsOperation() {
        return Context.getInstance()._showNewsOperation
    }

    static bindNewsFormOperation() {
        return Context.getInstance()._bindNewsFormOperation
    }

    static showNewsRemoveOperation() {
        return Context.getInstance()._showNewsRemoveOperation
    }

    static getInstance() {
        if (Context._instance == null) {
            let context = new Context();

            context._newsRepository = new NewsRepository()
            context._showNewsOperation = new ShowNewsOperation(context._newsRepository)
            context._bindNewsFormOperation = new BindNewsFormOperation(context._newsRepository)
            context._showNewsRemoveOperation = new ShowNewsRemoveOperation(context._newsRepository)

            Context._instance = context
        }
        return this._instance
    }

    constructor() {
        if (Context._instance != null) {
            throw new Error("Context is Singleton, use static method getInstance")
        }
    }
}