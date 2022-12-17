Feature:Profile

I want to be able to add description, languages and skills to my profile and be able to see them.

@tag1
Scenario: 1 Add description of the seller
	Given I logged into localhost successfully
	When I edit the description feature
	Then I am able to see the description

Scenario Outline: 2 Add languages to my profile
	When I navigate to languages tab
	And I add new '<Language>','<Level>' to my profile
	Then I am able to see '<Language>' added to my profile
Examples: 
	| Language | Level  |
	| Hindi    | Conversational |
	| French   | Basic  |
	| Korean   | Basic |

Scenario Outline: 3 Edit existing languages
	When I navigate to languages tab
	And I edit the exsisting language '<Language>','<Level>'
	Then I am able to see the edited language '<Language>'
Examples: 
	| Language  | Level            |
	| Malaysian | Native/Bilingual |

Scenario Outline: 4 Delete existing language
	When I navigate to languages tab
	And I delete a language '<Language>'
	Then I am not able to see the languge in profile '<Language>'
Examples: 
| Language  |
| Malaysian |

Scenario Outline: 5 Add skills to my profile
	When I navigate to the skills tab
	And I add new '<Skills>' and '<Level>'to my profile
	Then I am able to see my '<Skills>' added to my profile
Examples: 
| Skills     | Level        |
| Ballet     | Expert       |
| Cooking    | Intermediate |
| Acrobatics | Expert       |
| Painting   | Intermediate |

Scenario Outline: 6 Edit existing skills
	When I navigate to the skills tab
	And I edit the exsisting skills '<Skills>','<Level>'
	Then I am able to see the edited skills '<Skills>'
Examples: 
| Skills | Level  |
| Tango  | Expert |

Scenario Outline: 7 Delete existing skill
	When I navigate to the skills tab
	And I delete a skill '<Skill>'
	Then I am not able to see the skill in my profile '<Skill>'
Examples: 
| Skill |
| Tango |