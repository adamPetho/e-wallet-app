
var logout = document.getElementById("logout_div");
if (logout !== null) {
    logout.addEventListener('click', (ev) => {
        window.location.href = '/Forms/Logout';
    });
}

var add_money = document.getElementById("add_money_btn");
if (add_money !== null) {
    add_money.addEventListener('click', (ev) => {
        window.location.href = '/Forms/AddMoney';
    });
}

var payout_button = document.getElementById("payout_btn");
if (payout_button !== null) {
    payout_button.addEventListener('click', (ev) => {
        window.location.href = '/Forms/Payout';
    });
}

var sign_up = document.getElementById("sign_up_btn");
if (sign_up !== null) {
    sign_up.addEventListener('click', (ev) => {
        window.location.href = '/Forms/Register';
    });
}

var sign_in = document.getElementById("sign_in_btn");
if (sign_in !== null) {
    sign_in.addEventListener('click', (ev) => {
        window.location.href = '/Forms/Login';
    });
}

var clear_history_btn = document.getElementById("clear_history_btn");
if (clear_history_btn !== null) {
    clear_history_btn.addEventListener('click', (ev) => {
        window.location.href = '/ClearHistory';
    });
}