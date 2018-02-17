package outsystems.nosmusicdbexternaldata.records;

import java.io.Serializable;
import java.sql.*;
import java.math.BigDecimal;
import java.util.BitSet;
import org.w3c.dom.*;
import outsystems.objectkeys.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.hubedition.runtimeplatform.db.*;
import outsystems.internal.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.newruntime.*;
import outsystems.nosmusicdbexternaldata.records.*;

import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.recordlists.*;


public class RCt_MDDataPointRecord implements Serializable, Cloneable, ITypedRecord<RCt_MDDataPointRecord> {

	private static final GlobalObjectKey Idt_MDDataPoint = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*ZzTpXHhyw+cTx+UIiUegtA");

	public static void ensureInitialized() {}
	public ENt_MDDataPointEntityRecord ssENt_MDDataPoint;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MDDataPointEntityRecord toStructure() {
		return ssENt_MDDataPoint;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MDDataPointRecord(ENt_MDDataPointEntityRecord r) throws Exception {
		ssENt_MDDataPoint = (ENt_MDDataPointEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MDDataPoint.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MDDataPoint.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MDDataPointRecord() {
		OptimizedAttributes = null;
		ssENt_MDDataPoint = new ENt_MDDataPointEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(5, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MDDataPoint.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MDDataPoint.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MDDataPoint.OptimizedAttributes;
		return all;
	}

	/**
	 *
	 * Read a record from database
	 *
	 * @param  r
	 *         Data base reader
	 * @param  index
	 *         index
	 */
	public int read(OSResultSet r, int index) throws ClassCastException {
		index = ssENt_MDDataPoint.read(r, index);
		return index;
	}
	/**
	 *
	 * Read from database
	 *
	 * @param  r
	 *         Data reader
	 */
	public void readDB(OSResultSet r) {
		int index = 0;
		read(r, index);
	}

	/**
	 *
	 * Read from record
	 *
	 * @param  r
	 *         Record
	 */
	public void readIM(RCt_MDDataPointRecord r) throws Exception {
		this.ssENt_MDDataPoint = (ENt_MDDataPointEntityRecord) r.ssENt_MDDataPoint.duplicate();
	}


	/**
	 *
	 * Comparison Function
	 *
	 * @param  obj
	 *         Object to compare to.
	 *
	 * @return  True if equal
	 */
	public boolean equals(Object obj) {
		if ((obj == null) || !(obj instanceof RCt_MDDataPointRecord)) {
			return false;
		}
		RCt_MDDataPointRecord b = (RCt_MDDataPointRecord) obj;
		if (!this.ssENt_MDDataPoint.equals(b.ssENt_MDDataPoint)) return false;
		return true;
	}

	/**
	 *
	 * Hash Value Function
	 *
	 * @return  A hash value for the instance
	 */
	public int hashCode() {
		try {
			return super.hashCode() ^ ssENt_MDDataPoint.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MDDataPoint.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MDDataPoint.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MDDataPointRecord duplicate() throws Exception {
		RCt_MDDataPointRecord t = new RCt_MDDataPointRecord();
		t.ssENt_MDDataPoint = (ENt_MDDataPointEntityRecord) this.ssENt_MDDataPoint.duplicate();
		t.OptimizedAttributes = null;
		return t;
	}

	public IRecord duplicate$IRecord() throws Exception {
		return duplicate();
	}
	public void toXml(Object parent, Element baseElem, String fieldName, int detailLevel) {
		Element recordElem = VarValue.appendChild(baseElem, "Record");
		if (fieldName != null) {
			VarValue.appendAttribute(recordElem, "debug.field", fieldName);
		}
		if (detailLevel > 0) {
			ssENt_MDDataPoint.toXml(this, recordElem, "t_MDDataPoint", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_mddatapoint")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MDDataPoint")) variable.setValue(ssENt_MDDataPoint); else variable.setOptimized(true);
			variable.setFieldName("t_mddatapoint");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MDDataPointRecord t = (RCt_MDDataPointRecord) super.clone();
		t.ssENt_MDDataPoint = (ENt_MDDataPointEntityRecord) this.ssENt_MDDataPoint.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MDDataPoint.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MDDataPoint.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MDDataPoint)) {
			return ssENt_MDDataPoint;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MDDataPoint.fillFromOther((IRecord) other.attributeGet(Idt_MDDataPoint));
	}
}
