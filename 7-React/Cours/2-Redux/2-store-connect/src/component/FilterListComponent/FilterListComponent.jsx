import React from 'react';
import { connect } from 'react-redux';
import { setFilter } from '../../redux/actions/todosActions';
import { VISIBILITY_FILTER } from '../../redux/constants/Visibility'
import './FilterListComponent.css'

const FilterListComponent = ({activeFilter , setFilter}) => {
    return (
        <div className='visibility-filters'>
            {Object.keys(VISIBILITY_FILTER).map(filterKey => {
                const currentFilter = VISIBILITY_FILTER[filterKey]
                return (
                    <span
                        key={`visibility-filter-${currentFilter}`}
                        className={currentFilter !== activeFilter ? "filter" : "active-filter"}
                        onClick={()=>{
                            setFilter(currentFilter)
                        }}
                    >
                        {currentFilter}
                    </span>
                );
            })}
        </div>
    );
};
const mapStateToProps = state => {
    return { activeFilter: state.visibilityFilter };
}
// export default FilterListComponent;
export default connect(mapStateToProps, { setFilter })(FilterListComponent)