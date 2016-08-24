#Uuencoding

Unix-to-Unix Encoding. 


    Start with 3 bytes from the source, 24 bits in total.
    
    Split into 4 6-bit groupings, each representing a value in the range 0 to 63: bits (00-05), (06-11), (12-17) and (18-23).
    Add 32 to each of the values. With the addition of 32 this means that the possible results can be between 32 (" " space) and 95 ("_" underline). 96 ("`" grave accent) as the "special character" is a logical extension of this range.
    
    Output the ASCII equivalent of these numbers.


   print(uuencode('a new life is the most important thing for someone who\'s depressed', 'file.txt'))
   
   begin 644 file.txt
   lPP;LO>#9IS98-/.#IHRP;=_/I!IV\-_+IAW=(.FC3NSP9M_*#GOVY=^[+!WT;Y^<&3+PY9>?/+D 
   `
   end
