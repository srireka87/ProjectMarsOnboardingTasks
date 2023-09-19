Feature: LanguageFeature

As a ProjectMars User
I want to Add,Update and Delete profile Langauage details
So that I can show people seeking what languags I hold 

@tag1
Scenario Outline:AddNew Language with Valid Credentials
	Given I logged in to ProjectMars successfully
	And I navigate to Profile Language Page
	When I '<AddLanguage>' and '<Language Level>'
	Then the'<AddLanguage>'and '<Language Level>' details should be created successfully

	Examples:
	| AddLanguage    | Language Level    |
	| French         | Basic             |
	| Spanish        | Fluent            |
	| Marathi        | Native/Bilingual	 |
	| Japanese       | Conversational    |
	

Scenario Outline:Updating Language with Valid credentials in Profile
	Given I logged in to ProjectMars successfully
	And I navigate to Profile Language Page
	When I Update '<AddLanguage>' and '<Language Level>' on existing records
	Then the record should be updated in '<AddLanguage>'and '<Language Level>' successfully

	Examples:
	| AddLanguage       | Language Level   |
	| English           | Fluent           |    
	| Mandarin          | Basic	           |



Scenario Outline: Adding & Updating  the sameLanguage
	Given I logged in to ProjectMars successfully
	And I navigate to Profile Language Page
	When I Add/Update '<SameLanguage>' and '<SameLanguage Level>' on existing records
	Then pop up message display as 'This language is already added to your language list.'
	

	Examples:
	| SameLanguage      | SameLanguage Level  |
	| French            | Basic               |    
	| Spanish           | Fluent              |



Scenario: Deleting the Language and Language Level
Given I logged in to ProjectMars successfully
And I navigate to Profile Language Page
When I click Delete Button 
Then the records should be deleted