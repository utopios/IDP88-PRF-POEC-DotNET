import React from 'react';

const CategoryComponent = ({ setActiveCategory, activeCategory, categoryList }) => {
    console.log(categoryList);
    return (
        <div className='category'>

            <div className="input-group mb-3">
                <select
                    name="category"
                    id="category"
                    className='form-select categories'
                    value={activeCategory}
                    onChange={(e) => setActiveCategory(e.target.value)}

                >
                    <option value="">Selectionner une catégorie</option>
                    {
                        categoryList.map(
                            (cat) => (
                                <option key={cat} value={cat}>{cat}</option>
                            )
                        )
                    }
                </select>
                <div className="input-group-append">
                    <button
                        className='btn btn-secondary'
                        onClick={() => setActiveCategory('')}
                    >
                        Reset
                    </button>
                </div>
            </div>




        </div>
    );
}

export default CategoryComponent;
