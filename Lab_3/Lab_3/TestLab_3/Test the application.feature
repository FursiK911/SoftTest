Feature: Test the application
its main function
and the reaction to errors

Scenario: Test correct path
Given I have valid path D:\Coursework\app
When I add a valid path to a text field
And I click on the add button to add the entry to the left list
Then A new entry appears in the left list

Scenario: Test incorrect path
Given I have invalid path D\Coursework\app
When I add a invalid path to a text field
And I click on the add button to add the entry to the right list
Then A new entry appears in the right list

Scenario: Test empty path
Given I have empty path
When I click on the add button to get a warning
Then There was a warning about an empty path

Scenario: Test remove an entry from the left list
Given I have valid path D:\Open Server 5.2.9\OSPanel\domains
When I add a valid path to a text field
And I click on the add button to add the entry to the left list
And I select the desired entry in the left list
And I click on the delete button to remove entries from the left list 
Then The entries is removed from the left list

Scenario: Test remove an entry from the right list
Given I have invalid path D\Open Server 5.2.9\OSPanel\domains
When I add a invalid path to a text field
And I click on the add button to add the entry to the right list
And I select the desired entry in the right list
And I click on the delete button to remove entries from the right list 
Then The entries is removed from the right list

Scenario: Test moving an entry from the left list to the right
Given I have valid path D:\Open Server 5.2.9\OSPanel\domains
When I add a valid path to a text field
And I click on the add button to add the entry to the left list
And I select the desired entry in the left list
And I click on the remove button to moving an entry from the left list to the right 
Then The entries is moving from the left list to the right

Scenario: Test moving an entry from the right list to the text field
Given I have invalid path D\Open Server 5.2.9\OSPanel\domains
When I add a invalid path to a text field
And I click on the add button to add the entry to the right list
And I select the desired entry in the right list
And I click on the move button to moving an entry from the left list to the text field
Then The entries is moving from the right list to the text field

Scenario: Test moving an empty entry from the right list to the text field
Given I have empty right list
When I click on the move button to moving an entry from the left list to the text field
Then There was a warning about an empty entry