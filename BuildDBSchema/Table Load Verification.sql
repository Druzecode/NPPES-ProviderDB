truncate table provider_other_name;
truncate table provider_practice_location;
truncate table provider_endpoint;
truncate table provider_taxonomy;
truncate table provider_identifier;
truncate table provider;


select count(1) from provider_other_name;
select count(1) from provider_practice_location;
select count(1) from provider_endpoint;
select count(1) from provider_taxonomy;
select count(1) from provider_identifier;
select count(1) from provider;


CREATE INDEX idx_provider 
ON provider (NPI);