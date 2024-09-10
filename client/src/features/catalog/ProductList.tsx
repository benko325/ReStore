import { Grid, Grid2 } from "@mui/material";
import { Product } from "../../app/models/product";
import ProductCard from "./ProductCard";

interface Props {
    products: Product[];
}

// TODO: use Grid2 instead of Grid
export default function ProductList({products}: Props) {
    return (
        <Grid container spacing={4}>
            {products.map(product => (
                <Grid item xs={3} key={product.id}>
                    <ProductCard product={product}/>
                </Grid>
            ))}
        </Grid>
    )
}