using System;
using System.Collections.Generic;

Team team1= new Team();
Team team2 = new Team();
Team team3 = new Team();
Team team4 = new Team();
team1.win = 10;
team1.draw = 5;
team1.loss = 3;
// 35 points
team1.name = "Team A";
team2.win = 12;
team2.draw = 2;
team2.loss = 4;
// 38 points
team2.name = "Team B";
team3.win = 8;
team3.draw = 10;
team3.loss = 0;
// 34 points
team3.name = "Team C";
team4.win = 9;
team4.draw = 6;
team4.loss = 3;
// 33 points
team4.name = "Team D";
List<Team> TeamList = new List<Team>();
{
    TeamList.Add(team1);
    TeamList.Add(team2);
    TeamList.Add(team3);
    TeamList.Add(team4);
}
var winner = TeamList[0];

WinnerIs(TeamList);

void WinnerIs(List<Team> teams)
{
    foreach (var team in teams)
    {
        if (team.Points > winner.Points)
        {
            winner = team;
        }
    }
    Console .WriteLine($"The winner is {winner.name} with {winner.Points} points.");
}