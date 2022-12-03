import React from 'react';
import clsx from 'clsx';
import styles from './styles.module.css';
/*TODO: Change to your project's feature list*/
const FeatureList = [
  {
    title: 'Easy to Play',
   
    description: (
      <>
        Easy and fun to play! whether you want to play for a couple minutes,
        or a couple hours! Sokroban is perfect for any occasion
      </>
    ),
  },
  {
    title: 'Multiplayer',
    
    description: (
      <>
        Looking for a game to play with freinds ? Sokroban has got you covered ! Play with a 
        friend and attempt to concur Sokroban's endless levels, or go toe to toe in competative mode.
      </>
    ),
  },
  {
    title: 'Challenge Mode',
    
    description: (
      <>
        Looking to test your skills ? give Sokrobans Challenge mode a whirls, and see 
        how far you can get without the use of undos and resets.
      </>
    ),
  },
];

function Feature({Svg, title, description}) {
  return (
    <div className={clsx('col col--4')}>
      <div className="text--center">
      </div>
      <div className="text--center padding-horiz--md">
        <h3>{title}</h3>
        <p>{description}</p>
      </div>
    </div>
  );
}

export default function HomepageFeatures() {
  return (
    <section className={styles.features}>
      <div className="container">
        <div className="row">
          {FeatureList.map((props, idx) => (
            <Feature key={idx} {...props} />
          ))}
        </div>
      </div>
    </section>
  );
}
