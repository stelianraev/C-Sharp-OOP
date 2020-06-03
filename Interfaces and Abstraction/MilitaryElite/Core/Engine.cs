using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace MilitaryElite.Core
{
    public class Engine
    {
        public void Run()
        {
            List<Soldier> soldiers = new List<Soldier>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {

                string[] soldierArgs = input
                    .Split(" ");

                string soldierType = soldierArgs[0];
                string id = soldierArgs[1];
                string firstName = soldierArgs[2];
                string lastName = soldierArgs[3];

                if (soldierType == "Private")
                {
                    decimal salary = decimal.Parse(soldierArgs[4]);

                    Private @private = new Private(id, firstName, lastName, salary);
                    soldiers.Add(@private);

                }
                else if (soldierType == "Spy")
                {
                    int codeNumber = int.Parse(soldierArgs[4]);
                    Spy @private = new Spy(id, firstName, lastName, codeNumber);
                    soldiers.Add(@private);
                }
                else if (soldierType == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(soldierArgs[4]);
                    List<string> ids = soldierArgs.Skip(5).ToList();
                    List<Private> privates = GetPrivates(ids, soldiers);

                    LieutenantGeneral general = new LieutenantGeneral(id, firstName, lastName, salary, privates);

                    soldiers.Add(general);
                }
                else if (soldierType == "Engineer")
                {
                    decimal salary = decimal.Parse(soldierArgs[4]);
                    string corps = soldierArgs[5];

                    List<string> repairArgs = soldierArgs.Skip(6).ToList();
                    List<Repair> repairs = GetRepairs(repairArgs);

                    try
                    {
                        Engineer engineer = new Engineer(id, firstName, lastName, salary, corps, repairs);
                        soldiers.Add(engineer);
                    }
                    catch (Exception)
                    {
                    }

                }
                else if (soldierType == "Commando")
                {
                    decimal salary = decimal.Parse(soldierArgs[4]);
                    string corps = soldierArgs[5];

                    List<string> missionArgs = soldierArgs.Skip(6).ToList();
                    List<Mission> missions = GetMissions(missionArgs);

                    try
                    {
                        Commando comando = new Commando(id, firstName, lastName, salary, corps, missions);

                        soldiers.Add(comando);

                    }
                    catch (Exception)
                    {
                    }
                }
            }

            foreach (var soldierObject in soldiers)
            {
                Console.WriteLine(soldierObject);
            }
        }

        public static List<Mission> GetMissions(List<string> missionArgs)
        {
            List<Mission> missions = new List<Mission>();

            for (int i = 0; i < missionArgs.Count; i += 2)
            {
                string codeName = missionArgs[i];
                string state = missionArgs[i + 1];

                try
                {
                    Mission mission = new Mission(codeName, state);
                    missions.Add(mission);
                     
                }
                catch (Exception)
                {
                }
            }

            return missions;
        }

        public static List<Repair> GetRepairs(List<string> repairArgs)
        {
            List<Repair> repairs = new List<Repair>();

            for (int i = 0; i < repairArgs.Count; i += 2)
            {
                string partName = repairArgs[i];
                int hoursWorked = int.Parse(repairArgs[i + 1]);

                Repair repair = new Repair(partName, hoursWorked);

                repairs.Add(repair);
            }

            return repairs;
        }

        public static List<Private> GetPrivates(List<string> ids, List<Soldier> soldiers)
        {
            List<Private> privates = new List<Private>();
            List<Soldier>filteredSoldiers = soldiers.Where(x => x.GetType().Name == nameof(Private)).ToList();
            
            foreach (var privateSoldier in filteredSoldiers)
            {
                if (ids.Contains(privateSoldier.Id))
                {
                    privates.Add((Private)privateSoldier);
                }
            }

            return privates;
        }
    }
}
