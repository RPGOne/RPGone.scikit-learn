define([], function() {
    return (function() {
        function Ticket (from, to, price) {
            this.id = Math.random();
            this.from = from;
            this.to = to;
            this.price = price;
        }

        Ticket.prototype.toString = function() {
            return "From: " + this.from + " To: " + this.to + " Price: " + this.price + " EUR";
        };

        return Ticket
    }());
});