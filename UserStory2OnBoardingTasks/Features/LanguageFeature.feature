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
	

Scenario Outline:Updating Language and Language Level with Valid credentials in Profile
	Given I logged in to ProjectMars successfully
	And I navigate to Profile Language Page
	When I Update '<UpdateAddLanguage>' and '<UpdateLanguage Level>' on existing records
	Then The'<UpdateAddLanguage>'and '<UpdateLanguage Level>' details should be updated successfully

	Examples:
	| UpdateAddLanguage | UpdateLanguage Level   |
	| English           | Fluent                 |    
	| Mandarin          | Basic	                 |




