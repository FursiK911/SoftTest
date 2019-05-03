Feature: SeleniumBDD
I want to check for a link in Google on Wikipedia unit testing
Check for articles about NUnit on Wikipedia
Check availability of the article in Russian

Scenario: Search "Unit Testing" in Google and find link in Wikipedia
Given I have opened Google search page
And I entered unit testing
When I press search button in Google
Then The search contains link in Wikipedia
And I click link in Wikipedia

Scenario: Search "NUnit" in Wikipedia and check russian language
Given I have opened Unit Testing page in Wikipedia
And I entered NUnit in search field
When I press search button in Wikipedia
Then I click link in Wikipedia
And Check the availability of Russian articles