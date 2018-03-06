using System;
using System.Collections.Generic;
using System.Text;

namespace FYP_GUI_v.__
{
    public class User
    {
        public string name;
        public int age;
        public double weight;
        public double height;
        public float bmi;
        public Boolean create_valid;

        public int runStep;
        public int jumpStep;
        public int sitStep;
        public int pushStep;

        public int runCount;
        public int jumpCount;
        public int sitCount;
        public int pushCount;

        public double run_calories;
        public double jump_calories;
        public double sit_calories;
        public double push_calories;

        public int run_dur_hour;
        public int run_dur_minute;
        public int run_dur_second;

        public string bmi_category;
        public double total_calories;
        public string bmi_suggestion_1;
        public string bmi_suggestion_2;
        public string bmi_suggestion_3;

        public User()
        {
            name = "";
            age = 0;
            weight = 0;
            height = 0;
            bmi = 0;

            runStep = 0;
            jumpStep = 0;
            sitStep = 0;
            pushStep = 0;

            runCount = 0;
            jumpCount = 0;
            sitCount = 0;
            pushCount = 0;

            run_calories = 0;
            jump_calories = 0;
            sit_calories = 0;
            push_calories = 0;

            run_dur_hour = 0;
            run_dur_minute = 0;
            run_dur_second = 0;


            bmi_category = "";
            total_calories = 0;

            bmi_suggestion_1 = "";
            bmi_suggestion_2 = "";
            bmi_suggestion_3 = "";

            create_valid = true;

        }

        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        public double getHeight()
        {
            return height;
        }
        public double getWeight()
        {
            return weight;
        }
        public double getbmi()
        {
            return bmi;
        }



        public int getRunStep()
        {
            return runStep;
        }
        public int getJumpStep()
        {
            return jumpStep;
        }
        public int getSitStep()
        {
            return sitStep;
        }
        public int getPushStep()
        {
            return pushStep;
        }


        public int getRunCount()
        {
            return runCount;
        }
        public int getJumpCount()
        {
            return jumpCount;
        }
        public int getSitCount()
        {
            return sitCount;
        }
        public int getPushCount()
        {
            return pushCount;
        }

        
        /// ///////////////////////function for get back each exercise calories///////////////////////////////// 
        
        public double getRunCalories()
        {
            return run_calories;
        }
        public double getJumpCalories()
        {
            return jump_calories;
        }
        public double getSitCalories()
        {
            return sit_calories;
        }
        public double getPushCalories()
        {
            return push_calories;
        }

///  ///////////////////////////////////////////////////////////////////////////////////////////////////////

/// ////////////////////////////////functions for getting runnig duration information////////////////////////////
///     
        public int getRunDurHour()
        {
            return run_dur_hour;
        }
        public int getRunDurMin()
        {
            return run_dur_minute;
        }
        public int getRunDurSec()
        {
            return run_dur_second;
        }

        
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public string getBmiCategory()
        {
            return bmi_category;
        }
        public double getTotalCalories()
        {
            return total_calories;
        }

         //////////////////////////////function for getting bmi suggestion /////////////////////////////////////

        public string getBmiSuggestion1()
        {
            return bmi_suggestion_1;
        }
        public string getBmiSuggestion2()
        {
            return bmi_suggestion_2;
        }
        public string getBmiSuggestion3()
        {
            return bmi_suggestion_3;
        }

      
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public Boolean getCreate_Valid()
        {
            return create_valid;
        }





        public void setName(string temp_name)
        {
            name = temp_name;
        }
        public void setAge(int temp_age)
        {
            age = temp_age;
        }
        public void setHeight(double temp_height)
        {
            height = temp_height;
        }
        public void setWeight(double temp_weight)
        {
            weight = temp_weight;
        }
        public void setCreate_Valid(Boolean temp)
        {
            create_valid = temp;
        }


        public void setRunStep(int temp)
        {
            runStep = temp;
        }
        public void setJumpStep(int temp)
        {
            jumpStep = temp;
        }
        public void setSitStep(int temp)
        {
            sitStep = temp;
        }
        public void setPushStep(int temp)
        {
            pushStep = temp;
        }


        public void setRunCount(int temp)
        {
            runCount = temp;
        }
        public void setJumpCount(int temp)
        {
            jumpCount = temp;
        }
        public void setSitCount(int temp)
        {
            sitCount = temp;
        }
        public void setPushCount(int temp)
        {
            pushCount = temp;
        }

        
        /// ///////////////////////////////function for setting each exercise calories///////////////////////////////
        
        public void setRunCalories(double temp)
        {
            run_calories = temp;
        }
        public void setJumpCalories(double temp)
        {
            jump_calories = temp;
        }
        public void setSitCalories(double temp)
        {
            sit_calories = temp;
        }
        public void setPushCalories(double temp)
        {
            push_calories = temp;
        }

        
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////
       
        /// /////////////////////////////functions for setting running duration information////////////////////////////
         
        public void setRunDurHour(int temp)
        {
            run_dur_hour = temp;
        }
        public void setRunDurMin(int temp)
        {
            run_dur_minute = temp;
        }
        public void setRunDurSec(int temp)
        {
            run_dur_second = temp;
        }


        
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public void setBmiCategory(string temp)
        {
            bmi_category = temp;
        }

        public void setTotalCalories(double temp)
        {
            total_calories = temp;
        }

        
        /////////////////////// function for setting bmi suggestion //////////////////////////////////////////////

        public void setBmiSuggestion1(string temp)
        {
            bmi_suggestion_1 = temp;
        }

        public void setBmiSuggestion2(string temp)
        {
            bmi_suggestion_2 = temp;
        }

        public void setBmiSuggestion3(string temp)
        {
            bmi_suggestion_3 = temp;
        }

        
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        




        public void calculate_bmi()
        {
            float temp_height = ((float)height/100);
            bmi = ((float)(weight)) / (temp_height * temp_height);
        }

        public void CheckRunDurFormat()
        {
            if (run_dur_second >= 60)
            {
                run_dur_second = run_dur_second - 60;
                run_dur_minute = run_dur_minute + 1;
            }
            if (run_dur_minute >= 60)
            {
                run_dur_minute = run_dur_minute - 60;
                run_dur_hour = run_dur_hour + 1;
            }
        }
            
    }
}
