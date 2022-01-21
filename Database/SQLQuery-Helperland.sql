Create database Helperland

Create Table tblUser
(
	user_id int Primary Key NOT NULL,
	user_first_name varchar(50) NOT NULL,
	user_last_name varchar(50) NOT NULL,
	user_email_id varchar(50) NOT NULL,
	user_mobile_no int NOT NULL,
	user_DOB date NOT NULL,
	user_address varchar(100) NOT NULL,
	user_pincode int NOT NULL,
	preferred_lang varchar(50),
	user_old_pswd varchar(50) NOT NULL,
	user_new_pswd varchar(50) NOT NULL
)

Create Table tblService_Provider
(
	provider_id int Primary Key NOT NULL,
	provider_first_name varchar(50) NOT NULL,
	provider_last_name varchar(50) NOT NULL,
	provider_email_id varchar(50) NOT NULL,
	provider_mobile_no int NOT NULL,
	provider_DOB date NOT NULL,
	provider_nationality varchar(30) NOT NULL,
	provider_gender varchar(10) NOT NULL,
	provider_pincode int NOT NULL,
	provider_house_no int NOT NULL,
	provider_street_no int NOT NULL,
	provider_city varchar(50) NOT NULL,
	provider_old_pswd varchar(50) NOT NULL,
	provider_new_pswd varchar(50) NOT NULL
)

Create Table tblAll_Service
(
	service_id int Primary Key NOT NULL,
	provider_id int  NOT NULL,
	user_id int NOT NULL,
	service_status varchar(50) NOT NULL,
	service_pincode int NOT NULL,
	service_date date NOT NULL,
	rescheduled_service_date date,
	service_time time NOT NULL,
	rescheduled_service_time time,
	totalservice__hours  int NOT NULL,
	extra_services  varchar(50),
	service_payment float NOT NULL,
	service_comments varchar(50),
	have_pat bit NOT NULL
)

Alter table tblAll_Service 
add constraint user_id_FK FOREIGN KEY (user_id) references tblUser(user_id)

Alter table tblAll_Service 
add constraint provider_id_FK FOREIGN KEY (provider_id) references tblService_Provider(provider_id)

Create Table tblOngoing_Service
(
	ongoing_service_id int NOT NULL,
	ongoing_provider_id int  NOT NULL,
	ongoing_service_date date NOT NULL,
	ongoing_rescheduled_service_date date,
	ongoing_service_time time NOT NULL,
	ongoing_rescheduled_service_time time,
	ongoing_service_accepted bit NOT NULL
)

Alter table tblOngoing_Service 
add constraint service_id_FK FOREIGN KEY (ongoing_service_id) references tblAll_Service(service_id)

Alter table tblOngoing_Service 
add constraint ongoing_provider_id_FK FOREIGN KEY (ongoing_provider_id) references tblService_Provider(provider_id)

Create Table tblNew_Service
(
	new_service_id int  NOT NULL,
	new_provider_id int  NOT NULL,
	service_status varchar(50) NOT NULL
)

Alter table tblNew_Service 
add constraint new_service_id_FK FOREIGN KEY (new_service_id) references tblAll_Service(service_id)

Alter table tblNew_Service 
add constraint new_provider_id_FK FOREIGN KEY (new_provider_id) references tblService_Provider(provider_id)

Create Table tblContact_form
(
	contact_id int Primary Key NOT NULL,
	contact_first_name  varchar(50) NOT NULL,
	contact_last_name varchar(50) NOT NULL,
	contact_mobile_no int NOT NULL,
	contact_purpose varchar(50) NOT NULL,
	contact_message varchar(50) NOT NULL,
)

Create Table tblSaved_cards
(
	card_number int Primary Key NOT NULL,
	user_id int NOT NULL,
)

Alter Table tblSaved_cards
add constraint user_card_id_FK FOREIGN KEY (user_id) references tblUser(user_id)