import { Category } from "./category";
import { People } from "./people";

export interface SearchResults {
    people :People[],
    categories: Category[]
}
