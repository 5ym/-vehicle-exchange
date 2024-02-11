CREATE TABLE users (
    id serial primary key,
    email varchar(255) not null,
    password varchar(255) not null,
    name varchar(256) not null,
    otp char(4),
    otp_exp timestamp,
    status_id smallserial not null,
    created_on timestamp default CURRENT_TIMESTAMP not null,
    updated_on timestamp default CURRENT_TIMESTAMP not null
);
CREATE TABLE cars (
    id serial primary key,
    maker_id smallserial,
    model varchar(200) not null,
    year smallserial,
    mileage integer,
    price serial,
    style_id smallserial,
    drive_train_id smallserial,
    driver_side_id smallserial,
    displacement_id smallserial,
    exterior_color_id smallserial,
    interior_color_id smallserial,
    fuel_id smallserial,
    transmission_id smallserial,
    description varchar(4000),
    status_id smallserial not null,
    created_on timestamp default CURRENT_TIMESTAMP not null,
    updated_on timestamp default CURRENT_TIMESTAMP not null,
    usre_id serial not null references users(id)
);
CREATE TABLE images (
    id serial primary key,
    car_id serial not null references cars(id),
    path varchar(255) not null
);