using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code_Testing
{
    internal static class Compare_Version_Numbers
    {

        //Given two version strings, version1 and version2, compare them. A version string consists of revisions separated by dots '.'. The value of the revision is its integer conversion ignoring leading zeros.

        //To compare version strings, compare their revision values in left-to-right order. If one of the version strings has fewer revisions, treat the missing revision values as 0.

        //Return the following:

        //If version1<version2, return -1.
        //If version1 > version2, return 1.
        //Otherwise, return 0.



        //Example 1:

        //Input: version1 = "1.2", version2 = "1.10"

        //Output: -1

        //Explanation:

        //version1's second revision is "2" and version2's second revision is "10": 2 < 10, so version1<version2.

        //Example 2:

        //Input: version1 = "1.01", version2 = "1.001"

        //Output: 0

        //Explanation:

        //Ignoring leading zeroes, both "01" and "001" represent the same integer "1".

        //Example 3:

        //Input: version1 = "1.0", version2 = "1.0.0.0"

        //Output: 0

        //Explanation:

        //version1 has less revisions, which means every missing revision are treated as "0".



        //Constraints:

        //1 <= version1.length, version2.length <= 500
        //version1 and version2 only contain digits and '.'.
        //version1 and version2 are valid version numbers.
        //All the given revisions in version1 and version2 can be stored in a 32-bit integer.

        public static int CompareVersion(string version1, string version2)
        {
            string v1 = "";
            string v2 = "";
            int iv1 = 0;
            int iv2 = 0;
            for (iv1 = iv1; iv1 <= version1.Length; iv1++)
            {
                if (iv1 == version1.Length || version1[iv1] == '.')
                {
                    for (iv2 = iv2; iv2 <= version2.Length; iv2++)
                    {
                        if (iv2 == version2.Length || version2[iv2] == '.')
                        {
                            if (int.Parse(v1) > int.Parse(v2))
                            {
                                return 1;
                            }
                            else if (int.Parse(v1) < int.Parse(v2))
                            {
                                return -1;
                            }
                            else if (iv2 == version2.Length && iv1 == version1.Length)
                            {
                                return 0;
                            }
                            else
                            {
                                v1 = "";
                                v2 = "";
                                iv2++;
                                break;
                            }
                        }
                        else
                        {
                            v2 += version2[iv2];
                        }
                    }
                }
                else
                {
                    v1 += version1[iv1];
                    continue;
                }

                if (iv2 - 1 == version2.Length && iv1 != version1.Length)
                {
                    iv2--;
                    v2 = "0";
                    continue;
                }
                else if (iv2 - 1 != version2.Length && iv1 == version1.Length)
                {
                    iv1--;
                    v1 = "0";
                }
            }
            return 0;
        }
    }
}
