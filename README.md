# Improve-Blog-Challenge
## What is this?
Training and interview entry task for developers aiming to join the live site team at Watchfinder. 

The idea behind this task is to measure developers' capabilities to work to slightly vague instructions but deliver quality software with best practices by spotting mistakes and refactor an existing code base.

## Setting up the app
1. Fork this repository. You'll need to make all changes on your forked copy to keep this repository in its original format. All changes you make going forward will need to be checked in (committed and pushed) on a regular basis and the remote app needs to be in a working condition at any given point. 
2. Clone your forked version locally and have a look through the application. The web app is a very simple blog application connecting to an API (which in turn gets its data from a remote source). 
3. Once you've got a local copy, you can set it up using the IDE of your choice, however, all the following steps are assuming you're using the latest Visual Studio Code. 
4. The recommended extensions for the app to be set up are:
    * C# for Visual Studio Code (Microsoft)
    * .NET Core Test Explorer (Jun Han)
    * NuGet Package Manager (jmrog)
5. In order to run both API and FrontEnd projects locally, you can use the built-in tasks (tasks.json). In VS Code, press Ctrl+P, then type ```>Tasks: Run Task``` and select ```run api``` or ```run frontend``` from the list. 
6. Similarly, to run tests, you can simply run the ```test``` task. 
7. By default, both the API and FrontEnd are forcing HTTPS to be used for their respective applications. If you haven't had a similar project set up on your machine, you might need to run ```dotnet dev-certs https --trust``` in PowerShell. [See this link](https://www.hanselman.com/blog/CommentView.aspx?guid=80ff6163-d06b-43a2-b1b1-f75c4fefdb10)  for further reference.

## The tasks
Please aim to complete as many tasks from the below list, but don't spend days on these items, they should be doable in the matter of an hour or two.

In case you have any observations regarding code quality (e.g. architectural improvements, recommendations, tech debt), please include these in a file titled ```observations.md``` and place it in the root of your solution. Should you have any impediments stopping you from completing any of these tasks, please include those in the same file.

1. Your first task is to introduce the ability of referencing posts by their title (or so-called *slug*). Currently all posts are referenced by their ID in the format of: /Posts/Details/{ID}. We'd like this optimised for SEO, and make the URLs a bit nicer. To do that, instead of the ID, we'll need to put a lower case, hyphenated version of the title (the slug). This also needs to be URL-friendly, so that any special characters are eliminated from it. Ideally, this needs to be stored as a new field in the Post object in the API.

2. Currently, the colour of the posts are randomly generated when the page is loaded. In order to improve this, we'd like to store these colours for each post in the API and reference those in the FrontEnd project instead of generating the colours in the FrontEnd when each page is loaded.

3. In each post's details, the commenters only have their name and avatar listed. Please make these two clickable that pops up an email prepopulated with the commenter's email address and the subject line of *Regarding your comment on {Post title}* - where you need to prepopulate the {Post title} field.

4. Add the count of comments to each post on the listing page (/Posts)

5. Add breadcrumbs to each page.

6. You might have noticed that the code in both projects has minimal test coverage. This needs to be improved for both the API and the FrontEnd.

7. Look through the code (both API and FrontEnd) to see where you can make improvements or standardise areas.

## Considerations

1. Some of the instructions are intentionally left a bit vague partly to make them look like a real-life request, partly so that you can apply your best knowledge. It's worth thinking about architectural considerations, potential areas for future improvement, tech debt and generally adding comments in the source code.

2. Before you write any code, think: is this the best way of going about fixing this issue?
   
3. When looking through the code, are there any areas that look inconsistent? Can you make these consistent?
   
4. Have you got proper test coverage?

5. Do you need to provide documentation along with the changes you made?

6. Are all settings stored in the correct place? Can they be moved out to a central area?

7. Is the communication between the API and the FrontEnd good / secure enough?
