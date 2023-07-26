FROM rust:1 as builder

WORKDIR /usr/src/myapp
COPY . .
RUN cargo build --release

FROM debian:bookworm-slim
COPY --from=builder /usr/local/cargo/bin/backend-ve /usr/local/bin/backend-ve
CMD [ "backend-ve" ]
EXPOSE 3000