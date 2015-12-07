Feature: QA_Works_Contact_Us_Page
	As an end user
	I want a contact us page
	So that I can find out more about QA Works exciting services

Background: I am on the QA Works HomePage
	Given I am on the QAWorks Staging Site

@ContactUs
Scenario: Valid Submision
	When I navigate to the Contact Us page
	Then I should be able to contact QAWorks with the following information
	| name          | email                | message                                   |
	| j.Bloggs    6 | j.Bloggs@qaworks.com | please contact me I want to find out more |


@ContactUs
Scenario: Invalid Submision - No name, email or message
	When I navigate to the Contact Us page
	And I click send
	Then I should see a error that says a name is required
	And I should see an error that says a message is required
	And I should see an eror that says an email is required

@ContactUs
Scenario: Invalid Email Address format
	When I navigate to the Contact Us page
	And I attempt to send a message to QAWorks with an incorrect Email Address format
	| name          | email				| message                                   |
	| j.Bloggs    6 | j.qaworks.com		| please contact me I want to find out more |
	And I should see an eror that says an email is required