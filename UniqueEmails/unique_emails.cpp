//this code will take an array of emails and assess if they are the same.

std::string *unique_emails(std::string emails[], int size)
{

    int arr_size = size;

    for (int i = 0; i != arr_size; i++)
    {
       emails[i].erase(std::remove(emails[i].begin(), emails[i].end(), '.'), emails[i].end()); //erase the dot

       int plus_pos, at_pos;

       if (emails[i].find('+') != std::string::npos)
       {
           plus_pos = std::find(emails[i].begin(), emails[i].end(), '+') - emails[i].begin();
           at_pos = std::find(emails[i].begin(), emails[i].end(), '@') - emails[i].begin();
       }

       if (plus_pos < at_pos)
       {
           for (int j = plus_pos; j != at_pos; j++)
           {
               emails[i][j] = ' ';

           }

       }

       emails[i].erase(std::remove(emails[i].begin(), emails[i].end(), ' '), emails[i].end());

   }

    return emails;
}
