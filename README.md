# JsonDataDocuments

An app created to learn one alternative to relational dbs as the 'database layer'

## Opening thoughts

My apps that require database storage (state persistence), which all of them do, SQL server and EF are starting to feel like too much

Apps of my scale don't need all that (but can include a crud 'repository' interface for such data sources)

## Objectives for the project

Learn about one alternative to relational dbs as the 'database layer'

## Learning resources

Likely all Microsoft Learn and other MS .NET docs; they probably have a good working example

## Language(s), tool(s), framework(s)

C#/WPF…Although I'm currently intrigued by apps that are not framework-dependent, since json as documents is new to me, I don't want to learn it and a new language/framework at the same time

## What could trip me up? Any hidden complexity?

I expect difficulties getting the layers to talk to each other, and I'm absolutely certain that there are hidden complexities that I'm going to be ready for, while not trying to predict them

## Features
- A first-time user specifies their data document location
- A user can enter their name and favorite color, and save it (which means persisting to the document)
- A user can look up the favorite color of their friends, by searching for a friend's name (which means retrieving a document)
- A user can see a list of all users w/ favorite colors
- Advanced: Update and delete functionality
	
## How it works in my head
- Data model for the user & fav color
- An 'API' class/service that handles document crud
- The WPF front end will have nav for the three (3) features and calls the document 'API'
