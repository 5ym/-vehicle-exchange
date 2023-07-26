FROM rust:1 as builder

WORKDIR /usr/src/myapp
RUN rustup target add wasm32-unknown-unknown \
    && cargo install trunk
COPY . .
RUN trunk build --release

FROM nginx:1
COPY --from=builder /usr/src/myapp/dist /usr/share/nginx/html