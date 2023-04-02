Feature: Login

    Background: User authorised and navigated to home page
        Given User navigate to the base page

    Scenario Outline: Successful login to application
        When User with "<login>" and "<password>" authorise into account
        Then Account username should be "<username>"

        Examples:
          | login           | password  | username      |
          | valid@gmail.com | validPass | History Maker |

    Scenario Outline: Invalid credentials scenario
        When User with "<login>" and "<password>" authorise into account
        Then Incorrect credentials modal contains "<text>"

        Examples:
          | login                      | password | text                               |
          | SomeInvalidCreds@gmail.com | 123      | Unrecognized username or password. |