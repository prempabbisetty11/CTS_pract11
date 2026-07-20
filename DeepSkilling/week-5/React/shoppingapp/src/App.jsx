class Cart{constructor(Itemname,Price){this.Itemname=Itemname;this.Price=Price}}
function OnlineShopping(){const items=[new Cart('Laptop',85000),new Cart('Mobile',32000),new Cart('Headphones',2500),new Cart('Keyboard',1800),new Cart('Mouse',900)];return <section className="panel"><h2>Online Shopping Cart</h2><table><thead><tr><th>Item</th><th>Price</th></tr></thead><tbody>{items.map(item=><tr key={item.Itemname}><td>{item.Itemname}</td><td>Rs. {item.Price}</td></tr>)}</tbody></table></section>}
export default function App(){return <main className="app"><OnlineShopping/></main>}
