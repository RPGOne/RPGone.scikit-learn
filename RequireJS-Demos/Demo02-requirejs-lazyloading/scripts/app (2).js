define('app', function(require) {
    var alerter = require('alerter');
    alerter('hello');

    /*
     var btn = document.createElement('button');
     btn.onclick = function() {
     require(['alerter'], function(alerter) {
     alerter('Hello');
     })
     };
     btn.textContent = "Say 'Hello'!";
     document.body.appendChild(btn);
     */
});
