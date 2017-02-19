define(['lodash', 'jsConsole', 'ticket'], function(_) {
    return (function() {
        function TicketRepository () {
            this._repo = [];
            this._soldTickets = [];
        }

        TicketRepository.prototype.addTicket = function(ticket) {
            jsConsole.writeLine("Adding ticket to repository...");
            jsConsole.writeLine("Ticket ID: " + ticket.id);
            this._repo.push(ticket);
        };

        TicketRepository.prototype.sellTicket = function(ticketId) {
            jsConsole.writeLine("Selling ticket with ID: " + ticketId);
            this._soldTickets.push(_.find(this._repo, function(ticket) {
                return ticket.id === ticketId;
            }));

            _.remove(this._repo, function(ticket) {
                return ticket.id === ticketId;
            });
        };

        TicketRepository.prototype.showAvailableTickets = function() {
            jsConsole.write('Available tickets:');
            if (this._repo.length !== 0) {
                printRepoEntities(this._repo);
            } else {
                jsConsole.writeLine('[No tickets available!]');
            }
            jsConsole.writeLine();
        };

        TicketRepository.prototype.showSoldTickets = function() {
            jsConsole.write('Sold tickets:');
            if (this._soldTickets.length !== 0) {
                printRepoEntities(this._soldTickets);
            } else {
                jsConsole.writeLine('[No tickets available!]');
            }
            jsConsole.writeLine();
        };

        function printRepoEntities(repo) {
            var elemNum = 1;
            _.forEach(repo, function (ticket) {
                jsConsole.write('<br />' + elemNum + ". " + ticket.toString());
                elemNum++;
            });
        }

        return TicketRepository
    }());
});