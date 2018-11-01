std::string shift_char(std::string str, int shift)
{
    for (int i = 0; i != str.size(); ++i)
    {
        char temp_ref = str[i];
        char *c = &temp_ref;
        str[i] = *c + shift;
    }

    return str;
}
