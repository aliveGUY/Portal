const template = document.createElement('template');
template.innerHTML = `
  <link href="/css/WebComponents/BurgerMenu.css" rel="stylesheet" />
  <div expanded="false">
    <div class="burger-stick"/>
  </div>
`;

export default class Burger extends HTMLElement {
  constructor() {
    super();
    const shadow = this.attachShadow({ mode: 'open' });
    shadow.append(template.content.cloneNode(true));
    this.burger = shadow.querySelector('[expanded]');
    this.burger.addEventListener('click', () => this.toggleExpanded());
  }

  static get observedAttributes() {
    return ['expanded'];
  }

  toggleExpanded() {
    const expanded = this.getAttribute('expanded');
    if (expanded === 'true') {
      this.setAttribute('expanded', 'false');
      this.burger.setAttribute('expanded', 'false');
    } else {
      this.setAttribute('expanded', 'true');
      this.burger.setAttribute('expanded', 'true');
    }
  }
}

customElements.define("burger-menu", Burger);
