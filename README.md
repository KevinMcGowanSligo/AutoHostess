# autohostess

Tables are sorted in an order of preference
1. Table 12 (table for 2)
2. Table 18 (table for 2)
3. Table 5 (table for 2)
4. Table 26 (table for 4)
5. Table 17 (table for 2)
6. Table 11 (table for 4)
7. Table 10 (table for 4)
8. Table 4 (table for 4)
9. Table 3 (table for 4)
10. Table 22 (table for 2)
11. Table 23 (table for 2)
12. Table 24 (table for 2)
13. Table 21 (table for 4)
14. Table 9 (table for 6)
15. Table 8 (table for 4)
16. Table 15 (table for 4)
17. Table 14 (table for 4)
18. Table 13 (table for 4)
19. Table 19 (table for 4)
20. Table 20 (table for 6)
21. Table 2 (table for 6)
22. Table 1 (table for 6)
23. Table 6 (table for 8)

First draft of sorting is the user enters start time and number of people. Search through the list (which should already be sorted in preference order) checking how many seats on table. If its a match check if its free etc.

Ways bookings can overlap
Existing booking             |------------------|
Overlapping Start      |----------|
Overlapping End                         |---------|
Subset                         |-----------|
Superset              |-----------------------------|

if stored in Database 

select *
from Bookings existingBooking
where
    existingBooking.FromDate <= @desiredEndDate and
    @desiredStartDate <= existingBooking.ThruDate
