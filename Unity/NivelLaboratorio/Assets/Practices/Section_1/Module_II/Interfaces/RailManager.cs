using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Practices.Section_1.Module_II.Interfaces
{
    public class RailManager : MonoBehaviour
    {
        [SerializeField] private List<Target> targetsToSpawn = new List<Target>();
        [SerializeField] private List<Target> targets = new List<Target>();
        [SerializeField] uint numberOfTargetsInRound;
        [Range(3f, 10f)] [SerializeField] private float maxTargetVelocity;
        [SerializeField] private float stepForSpawn;
        [SerializeField] Transform startPosition;
        [SerializeField] Transform endPosition;

        private uint targetsLeft;

        private void OnEnable() 
        {
            UIManager.Instance.RestartButton.onClick.AddListener( () => SortNewTargets() ) ;
        }

        private void Start()
        {
            PrepareTargets();
            SortNewTargets();
        }

        private void PrepareTargets()
        {
            for (int i = 0; i < numberOfTargetsInRound; i++)
            {
                float randomTargetVelocity = Random.Range(2f, maxTargetVelocity + 1);
                int randomTargetPrefab = Random.Range(0, targetsToSpawn.Count);

                Target newTarget = Instantiate(targetsToSpawn[randomTargetPrefab], startPosition.position, targetsToSpawn[randomTargetPrefab].gameObject.transform.rotation);
                newTarget.transform.SetParent(transform);
                newTarget.SetRailManager(this);
                newTarget.SetPointAndDistance(endPosition, randomTargetVelocity);
                newTarget.gameObject.SetActive(false);

                targets.Add(newTarget);
            }
        }

        private IEnumerator SpawnTargets()
        {
            for (int i = 0; i < targets.Count; i++)
            {
                targets[i].gameObject.SetActive(true);
                targetsLeft--;
                UIManager.Instance.ChangeStatusOfCounterText(targetsLeft.ToString());
                yield return new WaitForSeconds(stepForSpawn);
            }

            SpawnFinished();
        }

        public void ResetTarget(Target target)
        {
            target.gameObject.SetActive(false);
            target.transform.position = startPosition.position;
        }

        private void SpawnFinished()
        {
            UIManager.Instance.ChangeStatusOfRestartButton(true);
        }

        private void SortNewTargets()
        {
            targetsLeft = numberOfTargetsInRound;
            StartCoroutine(SpawnTargets());
            UIManager.Instance.ChangeStatusOfRestartButton(false);
        }
    }

}
