using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIGroupProject
{
    
    //our "Chromosome"
    class Schedule
    {
        public static int DAYHOURS = 10;
        public static int DAYNUM = 5;

        private int numCrossoverPoints;
        private int mutationSize;

        private int crossoverProb;
        private int mutationProb;

        private float fitnessValue;

        //class table for our chromosome, used to for first timeslot
        //used by a class
        private Dictionary<Course, int> classes;
        //private Dictionary<int, Course> classes;

        //time slots, 1 entry is 1 hour of class
        private List<List<Course>> timeSlots;
        

        //initializes chromosomes
        public Schedule(int numCrossover, int mSize, int cProb, int mProb)
        {
            numCrossoverPoints = numCrossover;
            mutationSize = mSize;
            crossoverProb = cProb;
            mutationProb = mProb;
            fitnessValue = 0;
        }

        //if we need to copy a schedule
        public Schedule(Schedule s)
        {
            numCrossoverPoints = s.numCrossoverPoints;
            mutationSize = s.mutationSize;
            crossoverProb = s.crossoverProb;
            mutationProb = s.mutationProb;
            fitnessValue = s.fitnessValue;
        }

        //our crossover function, which returns the offspring
        public Schedule Crossover(Schedule parent2)
        {
            Random rand = new Random();

            int r = rand.Next();

            //check probability of crossover
            if(r % 100 > crossoverProb)
            {
                //no crossover happened, copy first parent
                return new Schedule(this);
            }

            //new chromosome
            Schedule n = new Schedule(this);

            //number of classes
            int size = classes.Count;

            List<bool> crossPoints = new List<bool>(size);

            //determining random crosspoints
            for(int i = numCrossoverPoints; i > 0; i--)
            {
                while(true)
                {
                    int p = new Random().Next() % size;
                    if( !crossPoints[p] )
                    {
                        crossPoints[p] = true;
                        break;
                    }
                }
            }

            //our iterators for our parent chromosomes
            Dictionary<Course, int>.Enumerator e1 = classes.GetEnumerator();
            Dictionary<Course, int>.Enumerator e2 = parent2.classes.GetEnumerator();

            //puts us at the first element of the dictionaries
            e1.MoveNext();
            e2.MoveNext();

            bool first = new Random().Next() % 2 == 0;
            for(int i = 0; i < size; i++)
            {
                if(first)
                {
                    //adds class from 1st parent into the new chromosomes' table
                    n.classes.Add(e1.Current.Key, e1.Current.Value);

                }
                else
                {
                    //adds class from 2nd parent into the new chromosomes' table
                    n.classes.Add(e2.Current.Key, e2.Current.Value);

                }

                //crossover point; changes the source chromosome
                if (crossPoints[i])
                    first = !first;

                e1.MoveNext();
                e2.MoveNext();
            }

            n.CalculateFitness();

            return n;
        }

        //Mutates the chromosome
        public void Mutation()
        {
            Random r = new Random();
            int swap = r.Next(classes.Values.Count);
            // I don't know. Something needed to be added
            if (classes.ContainsValue(swap) == false)
                classes.Add(new Course("", 000), 1);
        }
        //calculates the fitness value of the chromosome
        public void CalculateFitness()
        {
            int score = 0;
       
        }

        //gets the fitnessValue
        public float GetFitness()
        {
            return fitnessValue;
        }
    }

    class GA
    {
        //our population of chromosomes
        private List<Schedule> chromosomes;

        //indices of best chromosomes (our best group)
        private List<int> bestChromosomes;

        //number of best Chromosomes saved
        private int bestListSize;

        //number of chromosomes replaced next generation
        private int replacedNextGen;

        //keeps track of our current generation
        private int currentGeneration;

        //initializes the GA
        public GA(int numChromosomes, int numReplacingChromosomes, int bestChromIndex)
        {

        }

        //returns our best chromosome in the population
        public Schedule GetBest()
        {
            return chromosomes.ElementAt(bestChromosomes.Last());
        }

        //returns current generation
        public int GetCurrentGen()
        {
            return currentGeneration;
        }

        public void AddToBestGroup(int chromIndex)
        {
            bestListSize++;
            bestChromosomes.Add(chromIndex);
        }

        //returns true if that chromosome is in the bestChromosomes
        public bool IsInBestGroup(int chromIndex)
        {
            if (bestChromosomes.Contains(chromIndex))
                return true;
            return false;
        }

        //clears the bestChromosomes
        public void ClearBest()
        {
            bestChromosomes.Clear();
            bestListSize = 0;
        }
    }
}
