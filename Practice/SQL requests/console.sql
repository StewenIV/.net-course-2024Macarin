create table Clients(
    id_client uuid primary key default uuid_generate_v4(),
    name varchar(50) not null,
    surname varchar(50) not null,
    phone_number varchar(20) not null,
    email varchar(50),
    age int check ( age >=0 and age <= 99),
    address varchar(100) not null,
    passport_details varchar(50),
    birth_date date,
    bonus decimal default 0,
    order_number serial not null,
    order_amount decimal
);

create table Employees(
    id_employee uuid primary key default uuid_generate_v4(),
    name varchar(50) not null,
    surname varchar(50) not null,
    phone_number varchar(20) not null,
    email varchar(50),
    age int,
    address varchar(100) not null,
    passport_details varchar,
    birth_date date,
    bonus decimal default 0,
    position varchar(50) not null,
    start_date date,
    end_date date,
    salary decimal not null,
);

create table Accounts(
    id_account uuid primary key default uuid_generate_v4(), 
    id_client uuid not null,
    currency_name varchar(20) not null,
    amount decimal not null,
    foreign key (id_client) references Clients(id_client)
    on delete cascade
    on update cascade
);

insert into Clients (id_client, name, surname, phone_number, email, age, address, passport_details, birth_date, bonus, order_amount) values
                        (default, 'Александр', 'Иванов', '+37377604520', 'alexander.ivanov@example.com', 30, 'Бендеры, ул. Ленина, д. 1', '1234 567890', '1993-05-01', 100.50, 2000.00),
                        (default, 'Мария', 'Петрова', '+79009876580', 'maria.petrova@example.com', 28, 'Санкт-Петербург, ул. Невский, д. 5', '1234 567891', '1995-03-15', 150.75, 1500.00),
                        (default, 'Дмитрий', 'Сидоров', '+37360565603', 'dmitry.sidorov@example.com', 45, 'Тирасполь, ул. Карла Либкнехта, д. 7', '1234 567892', '1978-07-20', 200.00, 3000.00),
                        (default, 'Анна', 'Кузнецова', '+79004567890', 'anna.kuznetsova@example.com', 35, 'Казань, ул. Баумана, д. 3', '1234 567893', '1988-11-10', 250.00, 2500.00),
                        (default, 'Иван', 'Смирнов', '+79001239876', 'ivan.smirnov@example.com', 50, 'Нижний Новгород, ул. Горького, д. 12', '1234 567894', '1973-08-25', 300.25, 3500.00),
                        (default, 'Екатерина', 'Попова', '+79007654322', 'ekaterina.popova@example.com', 22, 'Ростов-на-Дону, ул. Пушкина, д. 4', '1234 567895', '2001-01-30', 90.00, 900.00),
                        (default, 'Сергей', 'Лебедев', '+79003456789', 'sergey.lebedev@example.com', 40, 'Челябинск, ул. Чапаева, д. 6', '1234 567896', '1983-09-14', 180.00, 2800.00),
                        (default, 'Ольга', 'Васильева', '+79009876544', 'olga.vasilieva@example.com', 29, 'Самара, ул. Ленина, д. 8', '1234 567897', '1994-12-05', 120.00, 1600.00),
                        (default, 'Артем', 'Морозов', '+37377760506', 'artem.morozov@example.com', 33, 'Тирасполь, ул. Мира, д. 15', '1234 567898', '1990-02-18', 210.00, 3100.00),
                        (default, 'Татьяна', 'Федорова', '+79001234568', 'tatiana.fedorova@example.com', 38, 'Уфа, ул. Кирова, д. 20', '1234 567899', '1985-06-22', 160.00, 2200.00),
                        (default, 'Олег', 'Федоров', '+37391640650', 'oleg.fedorov@example.com', 30, 'Бендеры, ул. Космонавтов, д. 20', '1234 567900', '1989-07-02', 150.00, 2000.00);

insert into Employees values
                          (default, 'Игорь', 'Соловьев', '+79003456790', 'igor.solovyev@example.com', 36, 'Москва, ул. Кутузова, д. 15', '1234 567900', '1987-04-02', 100.00, 'Менеджер', '2023-01-01', '2024-01-01', 60000.00),
                          (default, 'Светлана', 'Михайлова', '+79001239877', 'svetlana.mikhailova@example.com', 30, 'Санкт-Петербург, ул. Ломоносова, д. 25', '1234 567901', '1993-02-20', 150.00, 'Директор', '2022-03-15', '2023-03-15', 90000.00),
                          (default, 'Павел', 'Романов', '+37377604980', 'pavel.romanov@example.com', 40, 'Бендеры, ул. Гагарина, д. 10', '1234 567902', '1983-08-30', 200.00, 'Инженер', '2021-05-05', '2023-05-05', 750.00),
                          (default, 'Алина', 'Григорьева', '+79009876545', 'alina.grigorieva@example.com', 28, 'Казань, ул. Гагарина, д. 4', '1234 567903', '1995-11-15', 80.00, 'Маркетолог', '2022-06-10', '2023-06-10', 55000.00),
                          (default, 'Николай', 'Дмитриев', '+79003456791', 'nikolai.dmitriev@example.com', 50, 'Нижний Новгород, ул. Пушкина, д. 5', '1234 567904', '1973-01-20', 300.00, 'Аналитик', '2020-07-15', '2023-07-15', 80000.00),
                          (default, 'Елена', 'Лаврова', '+37377608504', 'elena.lavrova@example.com', 34, 'Кишинев, ул. Чайковского, д. 2', '1234 567905', '1989-09-25', 90.00, 'Бухгалтер', '2021-08-20', '2023-08-20', 600),
                          (default, 'Владимир', 'Сергеев', '+79004567892', 'vladimir.sergeev@example.com', 29, 'Челябинск, ул. Шевченко, д. 6', '1234 567906', '1994-05-30', 120.00, 'Системный администратор', '2022-02-15', '2023-02-15', 70000.00),
                          (default, 'Кристина', 'Орлова', '+79009876546', 'kristina.orlova@example.com', 31, 'Самара, ул. Крылова, д. 1', '1234 567907', '1992-06-28', 95.00, 'Дизайнер', '2021-10-05', '2023-10-05', 60000.00),
                          (default, 'Денис', 'Ковалев', '+79003456792', 'denis.kovalev@example.com', 42, 'Волгоград, ул. Пионеров, д. 3', '1234 567908', '1981-03-15', 110.00, 'Разработчик', '2020-09-20', '2023-09-20', 80000.00),
                          (default, 'Людмила', 'Шевченко', '+37377503506', 'lyudmila.shevchenko@example.com', 39, 'Бендеры, ул. Ленина, д. 8', '1234 567909', '1984-12-12', 140.00, 'HR-менеджер', '2022-11-11', '2023-11-11', 500);
                
insert into Accounts values
                         (default, (select id_client from Clients where name = 'Александр' and surname = 'Иванов'), 'RUB', 150000.00),
                         (default, (select id_client from Clients where name = 'Мария' and surname = 'Петрова'), 'EUR', 800.00),
                         (default, (select id_client from Clients where name = 'Дмитрий' and surname = 'Сидоров'), 'USD', 12000.00),
                         (default, (select id_client from Clients where name = 'Анна' and surname = 'Кузнецова'), 'RUB', 95000.00),
                         (default, (select id_client from Clients where name = 'Иван' and surname = 'Смирнов'), 'EUR', 400.00),
                         (default, (select id_client from Clients where name = 'Екатерина' and surname = 'Попова'), 'USD', 650.00),
                         (default, (select id_client from Clients where name = 'Сергей' and surname = 'Лебедев'), 'RUB', 18000.00),
                         (default, (select id_client from Clients where name = 'Ольга' and surname = 'Васильева'), 'EUR', 7500.00),
                         (default, (select id_client from Clients where name = 'Артем' and surname = 'Морозов'), 'USD', 1100.00),
                         (default, (select id_client from Clients where name = 'Татьяна' and surname = 'Федорова'), 'RUB', 6000.00),
                         (default, (select id_client from Clients where name = 'Олег' and surname = 'Федоров'), 'EUR', 300.00),
                         (default, (select id_client from Clients where name = 'Александр' and surname = 'Иванов'), 'EUR', 200.00),
                         (default, (select id_client from Clients where name = 'Мария' and surname = 'Петрова'), 'USD', 300.00),
                         (default, (select id_client from Clients where name = 'Иван' and surname = 'Смирнов'), 'RUB', 50000.00),
                         (default, (select id_client from Clients where name = 'Екатерина' and surname = 'Попова'), 'EUR', 100.00);

select c.name, c.surname, a.currency_name, a.amount from Clients c
join Accounts a on c.id_client = a.id_client
where (a.amount < 1000.00 and a.currency_name = 'USD')
   or (a.currency_name = 'EUR' and a.amount < 1100)
   or (a.currency_name = 'RUB' and a.amount < 100000.00)
order by a.amount;


select c.name, c.surname,a.currency_name, a.amount as min_amount from Clients c
join Accounts a on c.id_client = a.id_client
join (
    select currency_name, min(amount) as min_amount
    from Accounts
    where currency_name in ('USD', 'EUR', 'RUB')
    group by currency_name
) as min_accounts on a.currency_name = min_accounts.currency_name and a.amount = min_accounts.min_amount;

select sum(a.amount) as total_amount, a.currency_name from Accounts a
group by a.currency_name;

select c.name, c.surname,a.currency_name, a.amount from Clients c
join Accounts a on c.id_client = a.id_client
order by a.amount;

select c.name, c.surname, c.age from Clients c
order by c.age desc;
                        
select count(*) as count_clients, Clients.age from Clients
group by Clients.age
order by count_clients desc;

select age, count(*) as client_count from Clients
group by age
order by age;


with N as (
    select 1 as limit_value -- Задать значение N
)
select *
from Clients
limit (select limit_value from N);