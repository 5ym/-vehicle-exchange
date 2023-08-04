use axum::{response::Html, routing::get, Router};
use std::env;
use std::net::SocketAddr;
use sqlx::Pool;
use sqlx::postgres::Postgres;

#[tokio::main]
async fn main() {
    let database_url = env::var("DATABASE_URL").unwrap();
    let pool = Pool::<Postgres>::connect(&database_url).await.unwrap();
    sqlx::migrate!().run(&pool).await.unwrap();
    // build our application with a route
    let app = Router::new().route("/api", get(handler));

    // run it
    let addr = SocketAddr::from(([0, 0, 0, 0], 3000));
    println!("listening on {}", addr);
    axum::Server::bind(&addr)
        .serve(app.into_make_service())
        .await
        .unwrap();
}

async fn handler() -> Html<&'static str> {
    Html("<h1>Hello, World!</h1>")
}