# NovaFori test
### Time spend doing the solution
To do this I spend 3 hours and 30 mins approximately.
### How to run the solution
In a machine with .NET core 6 installed open the solution file located in:
```
/NovaForiTest/todolist/todolist.sln
```
with Visual Studio and run the project with `F5`
All the NuGet and node dependencies will be imported and compiled and the project will run the API backend and the react frontend.
### Technical and functional assumptions
- The frontend is a very basic `html` structure, but separated in components that would allow changing the UI without affecting the functionality
- For the Database I am using the in memory adapter of Entity Framework, meaning the data is only held in memory and it will be destroyed when the application restarts, but changing the adapter to connect to a persistent database is possible with minimum code changes
- I am assuming the list of tasks won't be too long for the purposes of this exercise, so no pagination has been added, and to refresh the UI I am reloading the tasks from the Database. This could be avoided updating the state of the component that lists the tasks instead of reloading in case we want to avoid it.
- I am assuming we don't need to separate the backend and frontend in different machines, so the .NET project is serving the react frontend too, but the react app is an independent app that could be extracted and run on it's own, leaving only the API functionality in the .NET project
### Design
For the backend I am using a Restful controller coded with ASP.NET core 6, using the Repository pattern for the data access to abstract the Entity Framework code from the application, and leave the controller actions code very simple.
I haven't created a generic repository class because for this exercise we only have one model, that would be a logical refactor if mode models are added to the system.
For the frontend I am using React with typescript, using functional components with hooks to manage the state, and basic `fetch` to make the API calls, to keep the dependencies at minimum.
For the purpose of the exercise I didn't think it was necessary to use the Context API to manage the state between components, but it would be useful once we have a few properties that are shared between components to avoid passing too many properties.
I feel this simple backend plus frontend project served by .NET is the best approach for this simple exercise, without limiting the possibility of improving it in case this became a real life project.

