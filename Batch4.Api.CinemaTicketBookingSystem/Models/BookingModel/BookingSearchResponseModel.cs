﻿using System;
namespace Batch4.Api.CinemaTicketBookingSystem.Models.BookingModel;

public class BookingSearchResponseModel
{
    public List<BookingSearch> lst { get; set; }
}
public class BookingSearch
{
    public string CustomerName { get; set; }
    public string MovieName { get; set; }
    public DateTime ShowTime { get; set; }
    public string SeatNumber { get; set; }
    public DateTime BookingHistory { get; set; }
}
