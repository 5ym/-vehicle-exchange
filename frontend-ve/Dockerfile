FROM node:lts as base
WORKDIR /usr/src/app
EXPOSE 3000
ENTRYPOINT [ "npm" ]

FROM base as builder
ENV NODE_ENV production
COPY package.json package-lock.json ./
RUN npm ci
COPY . .
RUN npm run build

FROM base
USER node
COPY --from=builder --chown=node:node /usr/src/app/.next/standalone .
COPY --from=builder --chown=node:node /usr/src/app/.next/static .next/static
ENTRYPOINT [ "node" ]
CMD [ "server.js" ]
