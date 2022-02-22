document.addEventListener('DOMContentLoaded', function() {

    let mainForm = document.getElementById('mainForm');

    let finalResultField = document.querySelector('.resultField');

    function getResult(t1, t2b1t1, t2b1t2, t2b2, t2b3, t2b4) {
        let t2b1 = (t2b1t1 + t2b1t2) / 2;
        let t2 = Math.round((t2b1 + t2b2 + t2b3 + t2b4) / 4); // Wird es bei der IHK Mittlerer-Niederrhein mathematisch aufgerundet?
        let finalResult = Math.round(t1 * 0.2 + t2 * 0.8); // Wird es bei der IHK Mittlerer-Niederrhein mathematisch aufgerundet?

        displayResult(t1, t2, finalResult, t2b1, t2b2, t2b3, t2b4);
        // console.log('Die Noten: ', t1, t2, "Die finale Note: ", finalResult, " ", finalResultField.innerHTML);
    }

    function displayResult(t1, t2, finalResult, t2b1, t2b2, t2b3, t2b4) {
        if (t1 < 50 || t2 < 50) {
            finalResultField.innerHTML = `Ihre Gesamtnote ist ${finalResult}. Sie haben die Prüfung leider nicht bestanden. Einer der Prüfungsteilen ist mangelhaft`;
            finalResultField.classList.add("text-danger");
            finalResultField.classList.remove("text-warning");
            finalResultField.classList.remove("text-success");
        } else if (t1 >= 50 && t2 >= 50 && (t2b1 <= 29 || t2b2 <= 29 || t2b3 <= 29 || t2b4 <= 29)) {
            finalResultField.innerHTML = `Ihre Gesamtnote ist ${finalResult}. Sie haben die Prüfung leider nicht bestanden. Einer Bereich des Teil II ist ungenügend`;
            finalResultField.classList.add("text-danger");
            finalResultField.classList.remove("text-warning");
            finalResultField.classList.remove("text-success");
        } else if (t1 >= 50 && t2 >= 50 && (t2b1 <= 49 || t2b2 <= 49 || t2b3 <= 49 || t2b4 <= 49)) {
            finalResultField.innerHTML = `Ihre Gesamtnote ist ${finalResult}. Sie haben die Prüfung bestanden, aber eine Note ist mangelhaft.`
            finalResultField.classList.add("text-warning");
            finalResultField.classList.remove("text-danger");
            finalResultField.classList.remove("text-success");
        } else {
            finalResultField.innerHTML = `Ihre Gesamtnote ist ${finalResult}. Sie haben die Prüfung erfolgreich bestanden, herzlichen Glückwunsch!`;
            finalResultField.classList.add("text-success");
            finalResultField.classList.remove("text-warning");
            finalResultField.classList.remove("text-danger");
        }
    }

    mainForm.addEventListener('submit', function(event) {
        event.preventDefault();

        let examPreliminary = Number(document.querySelector('.teil1').value);
        let examFinalSWProjekt1 = Number(document.querySelector('.teil2b1t1').value);
        let examFinalSWProjekt2 = Number(document.querySelector('.teil2b1t2').value);
        let examFinalSWProduct = Number(document.querySelector('.teil2b2').value);
        let examFinalAlgorithm = Number(document.querySelector('.teil2b3').value);
        let examFinalEconomySocial = Number(document.querySelector('.teil2b4').value);

        // console.log(examPreliminary, examFinalSWProjekt1, examFinalSWProjekt2, examFinalSWProduct, examFinalAlgorithm, examFinalEconomySocial);

        getResult(examPreliminary, examFinalSWProjekt1, examFinalSWProjekt2, examFinalSWProduct, examFinalAlgorithm, examFinalEconomySocial);
    })

    mainForm.addEventListener('reset', function() {
        finalResultField.innerHTML = "";
    })
})