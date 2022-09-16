// Jamie Lewis
// CST-150
// 9/16/22
// The comments and corrections made on this copied file are my own work.
// The code was copied from the assignment directions as instructed.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lydia's code - find the errors!
namespace CST117_IC08_console
{
     // Updated method naming convention to standards (names should begin with a capital letter).

     class Set
     {
          private List<int> elements;


          public Set()
          {
               elements = new List<int>();
          }

          public bool AddElement(int val)
          {
               if (ContainsElement(val)) return false;
               else
               {
                    elements.Add(val);
                    return true;
               }
          }

          // Bug #1
          // The 'i' in "i++' in the for loop initialization was underlined.
          // The popup tip on mouse hovering indicated that it was unreachable code.
          // This indicates that the loop will exit before any iterating is done.
          // In other words, it was only checking the first element in the Set.
          private bool ContainsElement(int val)
          {
               for (int i = 0; i < elements.Count; i++)
               {
                    if (val == elements[i])
                         return true;

                    // The solution here is to remove the "else return false;" lines from inside the loop.
                    // The method will return false after the for loop is completed if it does not return true first.
                    
                    //else
                    //     return false;
               }
               return false;
          } 

          public override string ToString()
          {
               string str = "";
               foreach (int i in elements)
               {
                    str += i + " ";
               }
               return str;
          }

          public void ClearSet()
          {
               elements.Clear();
          }

          // Bug #2
          // This Union method modifies the calling Set.
          // Bug #3
          // The passed parameter Set is returned insead of the combined elements.

          public Set Union(Set rhs)
          {
               // add temp Set variable
               Set temp = new Set();

               // copy this set
               for(int i = 0; i < this.elements.Count; i++)
			{
                    temp.AddElement(this.elements[i]);
			}

               for (int i = 0; i < rhs.elements.Count; i++)
               {
                    // Add elements of the passed Set (rhs) to the temp Set variable instead of to the  original Set
                    // this.AddElement(rhs.elements[i]);
                    temp.AddElement(rhs.elements[i]);
               }

               // return the temp Set instead of the passed Set.
               // return rhs;
               return temp;
          }
     }
}