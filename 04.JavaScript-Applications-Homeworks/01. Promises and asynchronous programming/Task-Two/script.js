window.alert("Redirecting...Check the site it has cool things.");

(function () {
    let promise = new Promise((resolve, reject) => {
        setTimeout(function (resolve) {
            window.location = "http://www.theuselessweb.com/";
        }, 2000);
    });
})();
