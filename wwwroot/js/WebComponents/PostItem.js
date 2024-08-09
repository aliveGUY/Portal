const template = document.createElement('template')
template.innerHTML = `
  <link href="/css/WebComponents/FeedItem.css" rel="stylesheet" />
  <a>
    <div class="feed-item">
      <h3 class="title">
        <slot name="title"></slot>
      </h3>
      <p class="description">
        <slot name="description"></slot>
      </p>
    </div>
  </a>
`

class Item extends HTMLElement {
  constructor() {
    super()
    const shadow = this.attachShadow({ mode: 'open' })
    shadow.append(template.content.cloneNode(true))
  }

  connectedCallback() {
    const href = this.getAttribute('href');
    const linkElement = this.shadowRoot.querySelector('a');

    if (href) {
      linkElement.setAttribute('href', href);
    }
  }
}
customElements.define("feed-item", Item)