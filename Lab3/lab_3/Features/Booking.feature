Feature: Booking

@Get
  Scenario: Get
    When send  GET request "https://restful-booker.herokuapp.com/booking"
    Then the response status code should OK

@GetById
Scenario Outline: GetBookingWithId
    When  send  GET request  "https://restful-booker.herokuapp.com/booking/:id" and tell the booking id:<ID>
    Then the response status code should OK
    Examples: 
    | ID   |
    | 1782 |
    | 514  |

@Auth
Scenario Outline: Auth
    When send  POST request "https://restful-booker.herokuapp.com/auth" with details "admin" and "password123"
    Then the response status code should OK

@Put
Scenario Outline: Put
    When send  POST request "https://restful-booker.herokuapp.com/auth" with details "admin" and "password123"
    And I create a booking with id:<booking_id>
    And send  PUT request "https://restful-booker.herokuapp.com/booking/:id" with this booking
    Then the response status code should OK
    Examples:
    | booking_id |
    | 505       |

@Delete
Scenario Outline: Delete
    When send  POST request "https://restful-booker.herokuapp.com/auth" with details "admin" and "password123"
    And I send a Delete request to "https://restful-booker.herokuapp.com/booking/:id" with a booking id:<booking_id>
    Then the response status code should be COMPLETED
    Examples: 
    | booking_id |
    | 1016        |


@POST
Scenario Outline: CreateBooking
    Given Booking with details:<totalprice>,<depositpaidcheckin>,<checkin>,<checkout>,<firstname>,<lastname>
    When send  POST request "https://restful-booker.herokuapp.com/booking" with selected booking details
    Then the response status code should OK
    Examples: 
    | firstname | lastname | totalprice | depositpaidcheckin | checkin    | checkout   |
    | Oleg      | David    | 240        | False              | 2018-01-01 | 2019-01-01 |
    | Yura      | Bodash   | 350        | True               | 2018-01-01 | 2019-01-01 |
