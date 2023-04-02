Feature: Login

    Scenario Outline: Login to application
        When User with "<login>" and "<password>" authorise into account
        Then User should be navigated to the home page 

        Examples:
          | login                 | password       |
          | paprika0020@gmail.com | 423489123789op |