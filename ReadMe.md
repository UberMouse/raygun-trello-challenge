# Raygun Trello Challenge

Simple website that lets you authenticate with Trello, view your Trello boards, their associated cards and add comments to them

Built using ASP.NET MVC4 on the backend and Bootstrap on the frontend. Makes use of [Manatee.Trello](https://github.com/gregsdennis/Manatee.Trello) to communicate with Trello on the backend.

In total this probably took me around 10-12 hours but mostly because of my unfamiliarity with ASP.NET and trying to figure out the analogies to what I know from Rails.

I was not able to figure out everything I wanted, so I apologize for some of the things left out. Couldn't figure out the routing properly, would have prefered more restful URLs. Same for form validation and storing the Trello token in a cookie; I had troubles accessing cooking data inside of a filter

## Running Instructions

1. Open Solution file in Visual Studio (it was created in 2015)
2. Install NuGet packages
3. Run website