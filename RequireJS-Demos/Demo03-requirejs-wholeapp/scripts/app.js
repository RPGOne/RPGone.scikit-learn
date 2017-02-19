define(['ticketRepository', 'ticket'], function(TicketRepository, Ticket) {
    var ticketRepo = new TicketRepository();
    var tickets = [
        new Ticket('Barcelona', 'London', 130),
        new Ticket('Sofia', 'Paris', 249)
    ];

    tickets.forEach(function(ticket) {
        ticketRepo.addTicket(ticket);
    });

    ticketRepo.showAvailableTickets();
    ticketRepo.sellTicket(tickets[0].id);
    ticketRepo.showAvailableTickets();
    ticketRepo.showSoldTickets();
});