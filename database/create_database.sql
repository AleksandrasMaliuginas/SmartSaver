begin;

drop schema if exists smartsaver cascade;

create schema smartsaver;



drop table if exists smartsaver.transactions cascade;

create table smartsaver.transactions (
	id bigserial not null,
	tr_time timestamp,
	amount decimal not null,
	details varchar(1000),
	counter_party varchar(1000),

	constraint "pk_smartsaver.transactions" primary key(id)
);

commit;