--use bme_db if you are not in correct place

alter table Hotels 

add HotelsShortDesc varchar(150) null 

go

select *
from Hotels