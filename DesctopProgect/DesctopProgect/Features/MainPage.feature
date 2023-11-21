Feature: Main page feature
wewe
@tests
Scenario: Fill in the document
	Given app is open
	When fill in the document with 'text'
	Then is the document fill in