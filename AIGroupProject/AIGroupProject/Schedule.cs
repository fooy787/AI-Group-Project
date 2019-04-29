using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIGroupProject
{
    //our "Chromosome"
    class Schedule
    {
        private int numCrossoverPoints;
        private int mutationSize;

        private int crossoverProb;
        private int mutationProb;

        private float fitnessValue;
        

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


        }

        //Mutates the chromosome
        public void Mutation()
        {

        }

        //calculates the fitness value of the chromosome
        public void CalculateFitness()
        {
            
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

        }

        //returns current generation
        public int GetCurrentGen()
        {
            return currentGeneration;
        }

        public void AddToBestGroup(int chromIndex)
        {

        }

        //returns true if that chromosome is in the bestChromosomes
        public bool IsInBestGroup(int chromIndex)
        {

        }

        //clears the bestChromosomes
        public void ClearBest()
        {

        }
    }
}
