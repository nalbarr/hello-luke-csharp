using System;

namespace Fall2017
{
    class Program
    {
        static void Main(string[] args)
        {
		// 1D as array, list or linear algebra vector of scalars
		IterateScalars1DWithIndexes();
		
		// 1D as array, list or linear algebra vector of scalars
		IterateScalars1DWithCollections();
		
		// 1D as array, list or linear algebra vector of <Object>
		IterateObjects1DWithIndexes();
		
		// 1D as collection of interfaces
		IterateInterfaces1DWithCollections();
		
		// 1D as collection of interfaces with type casting
		IterateInterface1DWithSpecificTypeCasts();
		
		// 1D as different collection types for different operations (e.g., get)
		CollectionsComplexity();
        }

		static void IterateScalars1DWithIndexes() {
            const int I_MAX = 5; 
            for (var i = 0; i < I_MAX; i++) 
            {
                System.Console.WriteLine("i: {0}", i);
            }
        }
		
		static void IterateScalars1DWithCollections() {
            // NAA. NLA - finish this.
        }
		
		// 1D as array, list or linear algebra vector of <Object>
		static void IterateObjects1DWithIndexes() {
            // NAA. NLA - finish this.            
        }
		
		// 1D as collection of interfaces
		static void IterateInterfaces1DWithCollections() {
            // NAA. NLA - finish this.
        }
		
		// 1D as collection of interfaces with type casting
		static void IterateInterface1DWithSpecificTypeCasts() {
            // NAA. NLA - finish this.
        }
		
		// 1D as different collection types for different operations (e.g., get)
		static void CollectionsComplexity() {
            // NAA. NLA - finish this.
        }        
    }
}