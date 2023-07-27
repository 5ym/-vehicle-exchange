use yew::prelude::*;
use crate::components::container::Container;

#[function_component]
pub fn Search() -> Html {
    html! {
        <Container id="search">
            <h1>{ "Secure" }</h1>
        </Container>
    }
}