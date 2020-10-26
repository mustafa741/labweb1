let rubInput = document.getElementById("rub");
let dolInput = document.getElementById("dol");

const dolInRub = 76.45

let dol_to_rub = dol => {
    return parseFloat(dol) * dolInRub
}

let rub_to_dol = rub => {
    return parseFloat(rub) / dolInRub
}

rubInput.addEventListener("change", _ => {
    let rub = rubInput.value;
    dolInput.value = rub_to_dol(rub)
})

dolInput.addEventListener("change", _ => {
    let dol = dolInput.value;
    rubInput.value = dol_to_rub(dol)
})
