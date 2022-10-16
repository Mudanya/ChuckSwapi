import { Category } from "./category";
import { People } from "./people";

export interface SearchResults {
    peopleResults :People[],
    categoriesResults: Category[]
}
