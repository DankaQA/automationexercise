Feature: ContactUs
	As a user
	Iwant to be able to work with Contact Us selection
	So I can customer support

@mytag
Scenario: User can send message via contact us form
Given user opens contact us page
When user enters all required fields
And user submits contact us form
And confirms the prompt message
Then user will receive 'Success! Your details have been submitted.' message