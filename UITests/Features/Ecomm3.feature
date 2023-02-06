Feature: Ecomm3

@regression
Scenario: Check my inventory with standard user 2
	Given the login page is loaded
	When the credentials are entered
	Then the inventory will be presented
	Examples: 
	| ID |
	| 1  |
	| 2  |
	| 3  |
	| 4  |
	| 5  |