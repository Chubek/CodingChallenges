//this code abbreviates two words. Given that the last character of the given string is not a space.

std::string abbr(std::string name)
{
    std::string result;
    result.push_back(name[0]);

    for (int i = 0; i != name.size(); ++i)
    {
        if (name[i] == ' ')
        {
            result.push_back('.');
            result.push_back(name[i+1]);
        }
    }

    return result;
}
