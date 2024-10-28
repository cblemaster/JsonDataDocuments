# JsonDataDocuments

## About
An app created to learn one alternative to relational dbs as the 'database layer'

## Built with
- NET 8 / C# 12
- Visual Studio Version 17.11.5
- WPF (Although I'm currently intrigued by apps that are not framework-dependent, since json as documents is new to me, I don't want to learn it and a new language/framework at the same time)

## Features
- A first-time user specifies their name and favorite color and is 'logged in' (new user created)
- A returning user 'logs in' and can see app options
	- User search
	- View all users
	- View user details
	- View own details
- Advanced: Update and delete functionality? [TBD]

## Business rules
- User names are required and must be 100 characters or fewer
- User names must be unique
- Favorite color options are pre-defined, there are ten (10) of them

## Misc documentation

### Opening thoughts

My apps that require data storage (state persistence), which all of them do, SQL server and EF are starting to feel like too much

Apps of my scale don't need all that (but can include a crud 'repository' interface for such data sources)

### Learning resources

Likely all Microsoft Learn and other MS .NET docs; they probably have a good working example
